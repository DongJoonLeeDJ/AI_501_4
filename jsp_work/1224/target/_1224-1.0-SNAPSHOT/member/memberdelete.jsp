<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String[] temp = request.getParameterValues("delidx");
    BoardDao bd = new BoardDao();
    String ret = bd.delete(temp);

    if(ret.equals("true"))
        response.sendRedirect("memberlist.jsp");
%>
</body>
</html>
