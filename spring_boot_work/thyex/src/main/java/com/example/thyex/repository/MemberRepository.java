package com.example.thyex.repository;

import com.example.thyex.entity.Member;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MemberRepository extends JpaRepository<Member,Long> {
    // select * from member where email ='' and pwd ='?';
    Member getByEmail(String email);
    // select * from member where email like '%email%';
    Page<Member> findByEmailContaining(String email, Pageable pageable);
//    Member getByPwd(String pwd);
//    Member getByEmailOrPwd(String email,String pwd);

    // select * from member order by id desc
}
