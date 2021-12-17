<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-17
  Time: 오전 10:55
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String send = request.getParameter("send");
    if(send.equals("true"))
        response.sendRedirect("index.jsp");
    else
        out.println("send 값은 false 입니다");
%>
<!--
    내장객체..4개를
    reqeust, response , out , session ( 회원 인증 시스템 )

    reqeust 한페이지에서 동작을 한다.
    request_befo -> request_after
    request_after 에서만 getParameter 로 구할수 있다.

    session 브라우저 창이 닫길때까지 동작을 한다.
    index.jsp setAttribute()... 지정을 하면
    어떤페이에서든지 getAttribute로 구할수가 있습니다.

    appcation tomcat이 종료 될때까지 동작을 한다.

-->
</body>
</html>
