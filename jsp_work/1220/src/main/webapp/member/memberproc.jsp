<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-20
  Time: 오전 10:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1220.dto.Member" %>
<%@ page import="com.example._1220.dao.MemberDao" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<% request.setCharacterEncoding("utf-8");%>
<jsp:useBean id="m1" class="com.example._1220.dto.Member"></jsp:useBean>
<jsp:setProperty name="m1" property="*"></jsp:setProperty>
<%--<jsp:setProperty name="m1" property="email"></jsp:setProperty>--%>
<%
    String email = request.getParameter("email");
    String pwd = request.getParameter("pwd");
//    String gender = request.getParameter("gender");
    // Java Bean...클래스..
//    Member m1 = new Member();
//    m1.setEmail(email);
//    m1.setPwd(pwd);
//    m1.setGender(gender);
    // java dao 클래스 생성
    MemberDao md = new MemberDao();
    // dao 클래스 안에 db table 삽입해주는 함수 호출
    md.insertmember(m1);
%>
<%=email%>
<%=pwd%>
<%--<%=gender%>--%>
<br>
<%=m1%>
</body>
</html>
