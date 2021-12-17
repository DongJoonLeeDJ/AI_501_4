<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-17
  Time: 오전 9:41
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    // 한글 처리 방식...
    request.setCharacterEncoding("utf-8");
    String a = request.getParameter("gugudan");
    out.println("a ="+a+"<br>");
    // 문자열을 숫자로 바꾸는거...
    int dannumber = Integer.parseInt(a);

    String b = request.getParameter("aaa");
    out.println("b ="+b+"<br>");
    String c = request.getParameter("ccc");
    out.println("c ="+c+"<br>");
%>
<%="<p>"%>
<%
    for(int i =1; i<10; i++){
        out.print(dannumber+"*"+i+"="+dannumber*i+"<br>");
    }
%>
<%="</p>"%>
<!--
get form 태그 사이에있는 값들이 주소 줄에 보이는거
post form 태그 사이에있는 값들이 주소 줄에 보이지 않는다.
-->
</body>
</html>
