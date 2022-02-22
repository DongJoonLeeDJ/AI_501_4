package com.example.thyex.controller;

import com.example.thyex.dto.MemberFormDto;
import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import com.example.thyex.service.MemberService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@Controller
@RequestMapping(value = "members")
public class MemberController {
     /*
        1. 중복나면 저장이 안되게끔.. MemberService..
        2. sprinbboot-starter-validation.jar 아이디와 패스워드가 입력이 안되면... 에러...
         -> BingdingResult
        3. th:obejct="${mebmerform}"
         ->th:field="*{email}"
         커맨드객체 사용방법
        4. select 오늘내일
         */

    //객체가 계속 생성되어져서 메모리 낭비를 초래한다
    @Autowired
    MemberService memberService;

    @Autowired
    MemberRepository memberRepository;

    @GetMapping("selectall")
    public String selectall(Model model,
                            @RequestParam(defaultValue = "0", required = false) int pageNum,
                            @RequestParam(defaultValue = "5", required = false) int size,
                            @RequestParam(defaultValue = "", required = false) String email
                            ){
        Pageable page = PageRequest.of(pageNum, size, Sort.by(Sort.Direction.DESC,"id"));
//        Page<Member> members = memberRepository.findAll(page);
        Page<Member> members = memberRepository.findByEmailContaining(email,page);
        System.out.println("getTotalPages = "+members.getTotalPages());
        model.addAttribute("members", members);
        return "members/selectall";
    }

    @GetMapping("insert")
    public String insert(Model model){
        model.addAttribute("memberFormDto",new MemberFormDto());
        return "members/insert";
    }

    @GetMapping("update")
    public String update(Model model, @RequestParam() Long id){
        Member member = memberRepository.findById(id).orElse(new Member());
        model.addAttribute("memberFormDto", new MemberFormDto(id,member.getEmail(), member.getPwd()));
        return "members/update";
    }

    @PostMapping("update")
    public String update(@Valid MemberFormDto memberFormDto, BindingResult bindingResult, Model model,Long id){
        if(bindingResult.hasErrors()){
            return "members/update";
        }
        Member member = Member.createMember(memberFormDto);
        member.setId(id);
        try {
            memberService.save(member);
        }
        catch (Exception e){
            System.out.println(e.toString());
            System.out.println("- 발생...");
            model.addAttribute("errorMessage","Email중복");
            return "members/update";
        }
        return "redirect:selectall";
    }

    @PostMapping("insert")
    public String insert(@Valid MemberFormDto memberFormDto, BindingResult bindingResult, Model model){
        if(bindingResult.hasErrors()){
            return "members/insert";
        }
        Member member = Member.createMember(memberFormDto);
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
