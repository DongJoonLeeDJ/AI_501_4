<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String[] temp = request.getParameterValues("delidx");
    MemberDao md = new MemberDao();
    String ret = md.delete(temp);

    if(ret.equals("true"))
        response.sendRedirect("memberlist.jsp");
%>
</body>
</html>
