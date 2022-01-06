package com.example._1224.member;

import com.example._1224.db.DBIn;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class MemberDao {
    // db select list...
    public List<MemberDto> memberlist() {
        List<MemberDto> list = new ArrayList<>();
        
        try{
            // jar 파일 있는지 확인
            Class.forName("com.mysql.cj.jdbc.Driver");
            // DB 연결
            Connection conn =
            DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa","root","1234");

            //sql 구문 작성
            //DB 명령어 쿼리 sql => 대문자 소문자 구분을 안함..
            // aa@naver.com AA@naver.com 내용으로는 대문자 소문자를 구분합니다.
            PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM MEMBER");

            // sql 구문 실행 및 테이블 반환...
            ResultSet rs = pstmt.executeQuery();
            // next() 함수...다음 행이 있으면 True 없으면 False 반환...
            // 반복자 처럼 위치 이동...
            while(rs.next()){
                list.add(new MemberDto(
                        rs.getInt("idx"),
                        rs.getString("email"),
                        rs.getString("pwd"),
                        rs.getString("gender"))
                );
            }
            
        }catch (Exception e){
            e.printStackTrace();
        }

//        list.add(new MemberDto("aa@naver.com","1234","남자"));
//        list.add(new MemberDto("bb@naver.com","1234","여자"));
        return list;
    }

    // db update
    public String memberset(MemberDto dto, boolean update){
        PreparedStatement pstmt = null;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn =
                    DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            pstmt = conn.prepareStatement("update member set email=?,pwd=?,gender=? where idx=?");

            pstmt.setString(1, dto.getEmail());
            pstmt.setString(2, dto.getPwd());
            pstmt.setString(3, dto.getGender());
            pstmt.setInt(4,dto.getIdx());

            pstmt.executeUpdate();
            return "true";
        }catch (Exception e){
            e.printStackTrace();
        }
        return "false";
    }

    // db insert...
    public void memberset(MemberDto dto){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn =
                DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa",
                                            "root",
                                            "1234");
            PreparedStatement pstmt =
                conn.prepareStatement("insert into member (email,pwd,gender) values (?,?,?)");

            pstmt.setString(1, dto.getEmail());
            pstmt.setString(2, dto.getPwd());
            pstmt.setString(3, dto.getGender());

            pstmt.executeUpdate();
        }catch (Exception e){
            e.printStackTrace();
        }
    }

    // select -> executeQuery()
    // insert, update, delete -> executeUpdate();

    // db select one...
    public MemberDto memberget(int idx) {
        try{
            // jar 파일 있는지 확인
            Class.forName("com.mysql.cj.jdbc.Driver");
            // DB 연결
            Connection conn =
                    DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa","root","1234");

            //sql 구문 작성
            //DB 명령어 쿼리 sql => 대문자 소문자 구분을 안함..
            // aa@naver.com AA@naver.com 내용으로는 대문자 소문자를 구분합니다.
            PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM MEMBER WHERE idx=?");
            pstmt.setInt(1,idx);

            // sql 구문 실행 및 테이블 반환...
            ResultSet rs = pstmt.executeQuery();
            // next() 함수...다음 행이 있으면 True 없으면 False 반환...
            // 반복자 처럼 위치 이동...
            while(rs.next()){
                return new MemberDto(
                        rs.getInt("idx"),
                        rs.getString("email"),
                        rs.getString("pwd"),
                        rs.getString("gender"));

            }

        }catch (Exception e){
            e.printStackTrace();
        }
        return new MemberDto();
    }

    // db member delete
    public String delete(String[] temp) {

        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;

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
            conn =
                    DriverManager.getConnection(
                            "jdbc:mysql://127.0.0.1:3306/aa",
                            "root",
                            "1234");
            pstmt =
                    conn.prepareStatement("DELETE FROM MEMBER WHERE IDX IN ("+idxs+")");
            pstmt.executeUpdate();
            return "true";
        }catch (Exception e){
            e.printStackTrace();
        }
        finally {
            try {
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            try {
                pstmt.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            try {
                conn.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }

        return "false";
    }

    public String memberchk(String id) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try{
            Class.forName(DBIn.jar);
            conn = DriverManager.getConnection(DBIn.url,DBIn.user,DBIn.pw);
            pstmt = conn.prepareStatement("SELECT COUNT(*) AS CNT FROM MEMBER WHERE EMAIL = ?");
            pstmt.setString(1, id);

            rs = pstmt.executeQuery();
            if(rs.next()) {
                int cnt = rs.getInt("CNT");
                if(cnt == 0)
                    return "true";
            }
        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try {
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            try {
                pstmt.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            try {
                conn.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
        return "false";
    }

    // 로그인 할수 있는지 없는지 체크 함수
    public boolean memberloginchk(String email, String pwd) {
        Connection conn = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        try{
            Class.forName(DBIn.jar);

            conn = DriverManager.getConnection(DBIn.url,DBIn.user,DBIn.pw);
            pstmt = conn.prepareStatement("select * from member where email=? and pwd=?");
            pstmt.setString(1, email);
            pstmt.setString(2, pwd);

            rs = pstmt.executeQuery();
            if(rs.next()) {
                // rs.next 가 되면 그 해당되는 행이 있으므로 반환값 true
                return true;
            }
        }
        catch (Exception e){
            e.printStackTrace();
        }finally {
            try {
                if (rs != null) rs.close();
                if (pstmt != null) pstmt.close();
                if (conn != null) conn.close();
            }catch (Exception e){}
        }
        return false;
    }
}
