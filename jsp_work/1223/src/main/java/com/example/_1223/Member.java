package com.example._1223;

import com.example._1223.dto.MemberDto;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.io.PrintWriter;

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
