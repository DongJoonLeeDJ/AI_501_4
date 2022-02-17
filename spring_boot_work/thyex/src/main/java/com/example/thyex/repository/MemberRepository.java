package com.example.thyex.repository;

import com.example.thyex.entity.Member;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MemberRepository extends JpaRepository<Member,Long> {
    Member getByEmail(String email);
}
