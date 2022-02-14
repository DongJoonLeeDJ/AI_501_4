package com.example.thyex.controller;

import com.example.thyex.dto.MemberFormDto;
import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "members")
public class MemberController {

    @Autowired
    MemberRepository memberRepository;

    @GetMapping("selectall")
    public String selectall(){
        return "members/selectall";
    }

    @GetMapping("insert")
    public String insert(){
        return "members/insert";
    }

    @PostMapping("insert")
    public String insert(MemberFormDto dto){
        System.out.println(dto);
        /*
            valid jar 파일 추가
            BingdingResut haserror
            pom.xml valid.jar
            MemberService ...
         */
        Member member = Member.createMember(dto);
        memberRepository.save(member);
        return "members/insert";
    }
}
