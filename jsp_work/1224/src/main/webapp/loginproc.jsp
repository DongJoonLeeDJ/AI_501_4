
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
    Object loginsave = request.getParameter("loginsave");
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
        if (loginsave != null)
        {
            Cookie co1 = new Cookie("email",email);
            Cookie co2 = new Cookie("pwd",pwd);

            co1.setMaxAge(60*1);
            co2.setMaxAge(60*1);

            response.addCookie(co1);
            response.addCookie(co2);
        };
        response.sendRedirect("index.jsp");
    }
    else{
        out.println("로그인할수 없음");
    }
%>
</body>
</html>
