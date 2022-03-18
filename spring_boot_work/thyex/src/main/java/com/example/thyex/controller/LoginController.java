package com.example.thyex.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "member")
public class LoginController {

    @GetMapping("login")
    public String login(){
        System.out.println("로긴폼 페이지 요청");
        return "member/login";
    }
}
