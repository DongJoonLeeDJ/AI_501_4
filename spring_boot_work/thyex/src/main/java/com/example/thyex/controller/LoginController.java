package com.example.thyex.controller;

import org.springframework.security.core.userdetails.User;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.servlet.http.Cookie;

@Controller
@RequestMapping(value = "member")
public class LoginController {

    @GetMapping("login")
    public String login(){
        System.out.println("로긴폼 페이지 요청");
        return "member/login";
    }

    @PostMapping("/jwtlogin")
    public APIResponse login(@RequestBody UserDto.Request user, HttpServletResponse response) {
        User member = userRepository.findById(user.getUserId())
                .orElseThrow(() -> new GeneralException(ACCOUNT_INVALID));

        if (!passwordEncoder.matches(user.getPassword(), member.getPassword())) {
            throw new GeneralException(PASSWORD_INVALID);
        }

        String token = jwtAuthenticationProvider.createToken(member.getUserId(), member.getRoles());
        response.setHeader("X-AUTH-TOKEN", token);

        Cookie cookie = new Cookie("X-AUTH-TOKEN", token);
        cookie.setPath("/");
        cookie.setHttpOnly(true);
        cookie.setSecure(true);
        response.addCookie(cookie);

        return APIResponse.of(UserDto.Response.builder()
                .userId(member.getUserId())
                .username(member.getUsername())
                .email(member.getEmail())
                .build());
    }
}
