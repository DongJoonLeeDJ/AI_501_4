package com.example._1224.board;

import com.example._1224.db.DBIn;
import com.example._1224.member.MemberDto;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class BoardDao {

    public List<BoardDto> selectlist(int pagenum){
        /*
            pagenum 1 = limit 0
            pagenum 2 = limit 5
            pagenum 3 = limit 10
            pagenum 4 = limit 15
            slimit = (pagenum -1) * 5
         */
        int slimit = (pagenum -1) * 5;

        List<BoardDto> list = new ArrayList<>();
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            pstmt =
                    conn.prepareStatement(
                            "SELECT * FROM board ORDER BY idx DESC LIMIT "+slimit+",5");
            rs = pstmt.executeQuery();
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
        finally {
            try {
                if (rs != null) rs.close();
                if (pstmt != null) pstmt.close();
                if (conn != null) conn.close();
            }catch (Exception e){}
        }
        return list;
    }

    public String insert(BoardDto dto) {
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            PreparedStatement pstmt =
                    conn.prepareStatement(
                            "INSERT INTO board " +
                                "(name, title,content,wdate) " +
                                "VALUES " +
                                "(?, ?, ?, NOW())");

            pstmt.setString(1,dto.getName());
            pstmt.setString(2,dto.getTitle());
            pstmt.setString(3,dto.getContent());

            pstmt.executeUpdate();
            return "true";
        }catch (Exception e){
            e.printStackTrace();
        }
        return "false";
    }

    public BoardDto selectrow(int idx) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try{
            Class.forName(DBIn.jar);
            conn = DriverManager.getConnection( DBIn.url, DBIn.user, DBIn.pw );
            pstmt =
                    conn.prepareStatement(
                            "SELECT * FROM BOARD WHERE IDX = ?");
            pstmt.setInt(1, idx);

            rs = pstmt.executeQuery();
            if(rs.next()){
                return new BoardDto(rs.getInt("idx"),
                                    rs.getString("name"),
                                    rs.getString("title"),
                                    rs.getString("content"),
                                    rs.getString("wdate"));
            }
        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try {
                if (rs != null) rs.close();
                if (pstmt != null) pstmt.close();
                if (conn != null) conn.close();
            }catch (Exception e){}
        }
        return new BoardDto();
    }

    public boolean delete(int idx) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        try{
            Class.forName(DBIn.jar);

            conn = DriverManager.getConnection(DBIn.url,DBIn.user,DBIn.pw);
            pstmt = conn.prepareStatement("DELETE FROM BOARD WHERE IDX=?");
            pstmt.setInt(1, idx);

            pstmt.executeUpdate();

            //select executeQuery
            // insert update delete executeupdate, execute
            return true;
        }catch (Exception e) {
            e.printStackTrace();
        }finally {
            try {
                if (pstmt != null)
                    pstmt.close();
                if (conn != null)
                    conn.close();
            }catch (Exception e){

            }
        }
        return false;
    }

    public boolean update(BoardDto dto) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        try{
            Class.forName(DBIn.jar);

            conn = DriverManager.getConnection(DBIn.url,DBIn.user,DBIn.pw);
            pstmt = conn.prepareStatement("UPDATE board " +
                                                "SET NAME=?, " +
                                                " title=?, " +
                                                " content=?, " +
                                                " wdate=now() " +
                                                "WHERE idx =?");
            pstmt.setString(1, dto.getName());
            pstmt.setString(2, dto.getTitle());
            pstmt.setString(3, dto.getContent());
            pstmt.setInt(4, dto.getIdx());

            pstmt.executeUpdate();

            //select executeQuery
            // insert update delete executeupdate, execute
            return true;
        }catch (Exception e) {
            e.printStackTrace();
        }finally {
            try {
                if (pstmt != null)
                    pstmt.close();
                if (conn != null)
                    conn.close();
            }catch (Exception e){

            }
        }
        return false;
    }

    public int selectpagecnt() {

        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            pstmt =
                    conn.prepareStatement(
                            "SELECT count(*) as pagecnt from board");
            rs = pstmt.executeQuery();
            if(rs.next()){
                int rowcnt = rs.getInt("pagecnt");
                /*
                    rowcnt -> 1,2,3,4,5 -> pagecnt = 1
                    rowcnt -> 6,7,8,9,10 -> pagecnt = 2
                    rowcnt -> 11,12,13,14,15 -> pagecnt = 3
                    rowcnt...
                    1...
                    0 + 1 = 1
                    5...
                    1 + 0 = 1
                    6...
                    1 + 1 = 2
                 */
                int pagecnt = (rowcnt/5) + (rowcnt%5>0? 1:0);
                return pagecnt;
            }
        }catch (Exception e){
            e.printStackTrace();
        }
        finally {
            try {
                if (rs != null) rs.close();
                if (pstmt != null) pstmt.close();
                if (conn != null) conn.close();
            }catch (Exception e){}
        }

        return 1;
    }
}
