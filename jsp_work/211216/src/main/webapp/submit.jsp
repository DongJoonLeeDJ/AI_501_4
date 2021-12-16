<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-16
  Time: 오후 12:14
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
서브밋.jsp 파일입니다.
<%
    // out... request... jsp 내장객체...
    // javascript document window location
    // 한글처리...
    // post... request.setCharacterEncoding
    // get... server.xml ... URIEncoding = "utf-8" tomcat8버전은..
    request.setCharacterEncoding("utf-8");
    String aapara = request.getParameter("aa");
    out.println(aapara);

    String dan = request.getParameter("gugu");
    out.println(dan);
%>

<!--
    a.jsp
    몇단 구구단 출력할래?
    input 태그에서 2 전송
    b.jsp
    2 * 2 = 4
    2 * 3 = 6
    ...
    2 * 9 = 18
    화이팅...
-->
</body>
</html>
