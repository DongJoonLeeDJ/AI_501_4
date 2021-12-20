<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-20
  Time: 오전 10:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1220.bean.Member" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String email = request.getParameter("email");
    String pwd = request.getParameter("pwd");
    String gender = request.getParameter("gender");
    // Java Bean...클래스..
    Member m1 = new Member();
    m1.setEmail(email);
    m1.setPwd(pwd);
    m1.setGender(gender);
%>
<%=email%>
<%=pwd%>
<%=gender%>
<br>
<%=m1%>
</body>
</html>
