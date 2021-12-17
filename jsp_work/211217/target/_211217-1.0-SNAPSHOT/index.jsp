<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<h1><%= "Hello World!" %>
</h1>
<br/>
<a href="hello-servlet">Hello Servlet</a>
<form action="gugudan.jsp" method="post">
    구구단 <input type="text" name="gugudan"><br>
    aaa <input type="text" name="aaa"><br>
    <input type="submit" value="전송">
</form>
<h1>reqeust사용해보기</h1>
<a href="request_befo.jsp">request_befo</a>
<h1>response사용해보기</h1>
<a href="response.jsp?send=true">바로돌아오기</a><br>
<a href="response.jsp?send=false">가보기</a>
</body>
</html>