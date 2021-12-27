<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<%@ page import="com.example._1224.member.MemberDto" %>
<%
    int idx = Integer.parseInt(request.getParameter("idx"));
    MemberDao dao = new MemberDao();
    MemberDto dto = dao.memberget(idx);
%>
<html>
<head>
    <title>Title</title>
    <%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp" %>
<div class="container">
    <form action="memberupdateproc.jsp">
        <input type="hidden" name="idx" value="<%=dto.getIdx()%>">
        <div class="form-group">
            <label for="email">email </label>
            <input type="email" class="form-control" placeholder="Enter email" id="email" name="email" value="<%=dto.getEmail()%>">
        </div>
        <div class="form-group">
            <label for="pwd">pwd:</label>
            <input type="text" class="form-control" placeholder="Enter password" id="pwd" name="pwd" value="<%=dto.getPwd()%>">
        </div>
        <div class="form-group form-check">
            <label class="form-check-label">
                <input class="form-check-input" type="radio" name="gender" value="남" <%=dto.getGender().equals("남")?"checked":""%> >남
            </label>
        </div>
        <div class="form-group form-check">
            <label class="form-check-label">
                <input class="form-check-input" type="radio" name="gender" value="여" <%=dto.getGender().equals("여")?"checked":""%> >여
            </label>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form>
</div>
</body>
</html>
