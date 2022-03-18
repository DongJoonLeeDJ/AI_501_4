package com.example.thyex.service;

import com.example.thyex.entity.Member;
import com.example.thyex.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

@Service // spring 객체 담는 통안에 객체 주입
public class MemberService {
//public class MemberService implements UserDetailsService {

    @Autowired
    MemberRepository memberRepository;

    public void save(Member member) throws Exception{
        Member db_member = memberRepository.findByEmail(member.getEmail());
        if(db_member != null)
            throw new Exception("그 해당 되는 행 email 있음..");
        memberRepository.save(member);
    }

//    @Override
//    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
//        System.out.println(username+"일로옴...");
//        return null;
//    }
}
