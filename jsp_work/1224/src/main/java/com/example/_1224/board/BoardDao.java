package com.example._1224.board;

import com.example._1224.member.MemberDto;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class BoardDao {
    public List<BoardDto> selectlist(){
        List<BoardDto> list = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM board");
            ResultSet rs = pstmt.executeQuery();
            while(rs.next()){
                list.add(
                        new BoardDto(rs.getInt("idx"),
                                rs.getString("name"),
                                rs.getString("title"),
                                rs.getString("content"),
                                rs.getString("wdate")));
            }
        }catch (Exception e){
            e.printStackTrace();
        }
        return list;
    }

    public String delete(String[] temp) {

        String idxs = "";
        // idxs = 1,2   length = 2
        for(int i = 0; i< temp.length ; i++){
            if ((temp.length-1) != i)
                idxs = idxs + temp[i] + ",";
            else
                idxs = idxs + temp[i];
        }
        System.out.println(idxs);

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            PreparedStatement pstmt =
                    conn.prepareStatement("DELETE FROM MEMBER WHERE IDX IN ("+idxs+")");
            pstmt.executeUpdate();
            return "true";
        }catch (Exception e){
            e.printStackTrace();
        }

        return "false";
    }
}
