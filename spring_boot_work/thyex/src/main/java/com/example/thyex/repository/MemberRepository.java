package com.example.thyex.repository;

import com.example.thyex.entity.Member;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MemberRepository extends JpaRepository<Member,Long> {
    // select * from member where email ='' and pwd ='?';
    Member getByEmail(String email);
//    Member getByPwd(String pwd);
//    Member getByEmailOrPwd(String email,String pwd);
}
