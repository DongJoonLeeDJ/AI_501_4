package com.example.thyex.controller;

import com.example.thyex.dto.MemberFormDto;
import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import com.example.thyex.service.MemberService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping(value = "members")
public class MemberController {
     /*
        1. 중복나면 저장이 안되게끔.. MemberService..
        2. valid.jar 아이디와 패스워드가 입력이 안되면... 에러...
         -> BingdingResult
        3. th:obejct="${mebmerform}"
         ->th:field="*{email}"
         커맨드객체 사용방법
        4. select 오늘내일
         */

    //객체가 계속 생성되어져서 메모리 낭비를 초래한다
    @Autowired
    MemberService memberService;

    @GetMapping("selectall")
    public String selectall(){
        return "members/selectall";
    }

    @GetMapping("insert")
    public String insert(){
        return "members/insert";
    }

    @PostMapping("insert")
//    @RequestMapping(value = "insert",method = RequestMethod.POST)
    public String insert(MemberFormDto dto, Model model){
        System.out.println(dto);
        // MemberFormDto -> Member(Entity) 객체로 바꿈..
        Member member = Member.createMember(dto);
        // member(Entity) 객체를 MemberService를 호출하면서...
        try {
            memberService.save(member);
        }
        catch (Exception e){
            System.out.println(e.toString());
            System.out.println("- 발생...");
            model.addAttribute("errorMessage","Email중복");
            return "members/insert";
        }
        return "redirect:selectall";
    }
}
