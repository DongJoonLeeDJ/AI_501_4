
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String email = request.getParameter("email");
    String pwd = request.getParameter("pwd");
    String loginsave = request.getParameter("loginsave");
%>
<%=email%>
<%=pwd%>
<%=loginsave%>
<%
    MemberDao dao = new MemberDao();
    boolean ret = dao.memberloginchk(email,pwd);
    if (ret){
        out.println("로그인할수 있음");
        // session에 설정
        // session 브라우저 창이 닫기전까지 변수값을 가지고 있다...
        // tomcat 기본적으로 가지고 있는 시간이..
        session.setAttribute("email",email);
        session.setAttribute("pwd",pwd);
    }
    else{
        out.println("로그인할수 없음");
    }
%>
</body>
</html>
