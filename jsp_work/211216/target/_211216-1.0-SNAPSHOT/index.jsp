<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<!--
    file
    a.jsp -> a_jsp a_jsp.class
    a.java -> a.class
    -> extends HttpServlet 상속받아서 하는 방법...
 -->
<%!
    // 메서드를 정의 할수가 있다....
    public void doA(){
        System.out.println("test");
    }
%>
<%
    doA();
    doA();
%>
<h1>
<%= "Hello World!" %>
<% out.print("Hello World!"); %>
</h1>
<br/>
<a href="hello-servlet">Hello Servlet</a><br>
<a href="MyServlet">MyServlet</a>
한글나오냐..
<form action="submit.jsp" method="post">
    <input type="text" name="aa" value="한글">
    <input type="submit" value="전송">
</form>
</body>
</html>