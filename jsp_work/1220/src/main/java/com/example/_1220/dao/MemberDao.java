package com.example._1220.dao;

import com.example._1220.dto.Member;

import java.sql.Connection;
import java.sql.DriverManager;

public class MemberDao {
    
    // db member table 안에 insert 해야함
    public void insertmember(Member m1){
        System.out.println(m1);
        System.out.println("테이블 삽입해야함");
//        Connection conn = DriverManager.getConnection("")
    }
}
