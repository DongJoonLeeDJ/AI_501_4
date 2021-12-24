package com.example._1224.member;

import java.util.ArrayList;
import java.util.List;

public class MemberDao {
    public List<MemberDto> memberlist() {
        List<MemberDto> list = new ArrayList<>();

        list.add(new MemberDto("aa@naver.com","1234","남자"));
        list.add(new MemberDto("bb@naver.com","1234","여자"));



        return list;
    }
}
