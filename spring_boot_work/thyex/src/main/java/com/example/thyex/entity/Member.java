package com.example.thyex.entity;

import com.example.thyex.dto.MemberFormDto;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;

import javax.persistence.*;

@Entity
@Getter
@Setter
@ToString
public class Member {
    //기본키...
    @Id
    @Column(name = "id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String email;
    private String pwd;

    public static Member createMember(MemberFormDto memberFormDto,PasswordEncoder passwordEncoder){
//        PasswordEncoder passwordEncoder = new BCryptPasswordEncoder();
        Member member = new Member();
        member.setEmail(memberFormDto.getEmail());
//        member.setPwd(memberFormDto.getPwd());
        member.setPwd(passwordEncoder.encode(memberFormDto.getPwd()));
        return member;
    }
}
