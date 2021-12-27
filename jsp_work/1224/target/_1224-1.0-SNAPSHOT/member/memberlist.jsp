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
    <style>
        .onmouse:hover{
            background-color: antiquewhite;
            cursor: pointer;
        }
    </style>
    <script>
        function memberupdate(idx){
            // alert(idx+' 눌렀니');
            location.href='memberformupdate.jsp?idx='+idx;
        }
    </script>
</head>
<body>
<%@ include file="../nav.jsp" %>
<div class="container">
    <table class="table">
        <thead>
            <tr>
                <th>이메일</th><th>패스워드</th><th>성별</th>
            </tr>
        </thead>
        <tbody>
    <%
        for( MemberDto dto : list) {
    %>
            <tr onclick="memberupdate(<%=dto.getIdx()%>);" class="onmouse">
                <td><%=dto.getEmail()%></td>
                <td><%=dto.getPwd()%></td>
                <td><%=dto.getGender()%></td>
            </tr>
    <%
        }
    %>
        </tbody>
    </table>
</div>
</body>
</html>
