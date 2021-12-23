package com.example._1223;

import com.example._1223.dto.MemberDto;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

@WebServlet(name = "Member", value = "/Member")
public class Member extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        
        response.setContentType("text/html");

        MemberDto dto = new MemberDto();
        dto.setEmail(request.getParameter("email"));
        dto.setPwd(request.getParameter("pwd"));
        dto.setGender(request.getParameter("gender"));
        System.out.println(dto);

        // select .. 할때도.. 디비 연결을 해야하고..
        // insert .. 할때도 디비 연결은 해야 합니다...
        try
        {
            // jar 파일 추가 되어 있는지 검사 하는 함수.
            Class.forName("com.mysql.cj.jdbc.Driver");
            // 디비 연결하는 거....
            Connection conn = DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa?serverTimezone=UTC","root","1234");

            PreparedStatement pstmt = conn.prepareStatement("INSERT INTO " +
                                                                "member " +
                                                                "(email, pwd, gender) " +
                                                                "VALUES " +
                                                                "('aa@naver.com', '5678', '여')");
            pstmt.executeUpdate();
            // insert update delete -> pstmt.executeUpdate() 로실행
            // select -> pstmt.executeQuery() 로 실행

            // sql 문 작성해야한다.
//            PreparedStatement pstmt = conn.prepareStatement("select * from member");
//            // sql 문 실행해야한다. table 반환되면 rs 담기
//            ResultSet rs = pstmt.executeQuery();
//            while(rs.next()){
//                System.out.println(rs.getString("email"));
//                System.out.println(rs.getString("pwd"));
//                System.out.println(rs.getString("gender"));
//            }

        }catch (Exception e){
            e.printStackTrace();
        }

//        request.setCharacterEncoding("utf-8");
//        response.setCharacterEncoding("utf-8");
        
        // pw 는 out 객체랑 동일하다..
        PrintWriter out = response.getWriter();
        out.println("<html><head></head><body>잘되나</body></html>");

        System.out.println("한글 출력");
        
        
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

    }
}
