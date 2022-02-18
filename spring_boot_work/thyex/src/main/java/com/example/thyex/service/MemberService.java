package com.example.thyex.service;

import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service // spring 객체 담는 통안에 객체 주입
public class MemberService {

    @Autowired
    MemberRepository memberRepository;

    public void save(Member member) throws Exception{

        // select * from member where email = ?
        // ? = member.getemail()
        Member db_member = memberRepository.getByEmail(member.getEmail());
        if(db_member != null)
            throw new Exception("그 해당 되는 행 email 있음..");

        memberRepository.save(member);
    }

}
