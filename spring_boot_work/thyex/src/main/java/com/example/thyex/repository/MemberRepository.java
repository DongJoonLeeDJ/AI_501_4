package com.example.thyex.repository;

import com.example.thyex.entity.Member;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import javax.transaction.Transactional;
import java.util.List;

public interface MemberRepository extends JpaRepository<Member,Long> {
    // select * from member where email ='' and pwd ='?';
    Member getByEmail(String email);
    // select * from member where email like '%email%';
    Page<Member> findByEmailContaining(String email, Pageable pageable);
//    Member getByPwd(String pwd);
//    Member getByEmailOrPwd(String email,String pwd);

    // delete * from member where id in (65,64);
//    @Query("delete * from member where id in :id")
    @Transactional
    long deleteAllByIdIn(List<Long> id);

}
