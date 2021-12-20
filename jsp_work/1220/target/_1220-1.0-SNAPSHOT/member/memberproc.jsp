<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-20
  Time: 오전 10:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String email = request.getParameter("email");
    String pwd = request.getParameter("pwd");
    String gender = request.getParameter("gender");
%>
<%=email%>
<%=pwd%>
<%=gender%>

</body>
</html>
