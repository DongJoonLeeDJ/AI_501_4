<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-24
  Time: 오전 9:50
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<%@ page import="com.example._1224.member.MemberDto" %>
<%@ page import="java.util.List" %>
<%
    // mysql 접근 객체
    MemberDao dao = new MemberDao();
    // memberlist 메서드는 db 가서 member 테이블 조회해서
    // list 형태로 값을 만들어주는 함수...
    List<MemberDto> list = dao.memberlist();
    System.out.println("memberlist.jsp list = "+ list);
%>
<html>
<head>
    <title>Title</title>
    <%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp" %>
<%
    for( MemberDto dto : list) {
%>
되나...
<%
    }
%>
</body>
</html>
