<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
%>
<html>
<head>
    <title>Title</title>
    <%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp" %>
<div class="container">
    <form action="memberproc.jsp">
        <div class="form-group">
            <label for="email">email </label>
            <input type="email" class="form-control" placeholder="Enter email" id="email" name="email" value="aa@naver.com">
        </div>
        <div class="form-group">
            <label for="pwd">pwd:</label>
            <input type="password" class="form-control" placeholder="Enter password" id="pwd" name="pwd" value="1234">
        </div>
        <div class="form-group form-check">
            <label class="form-check-label">
                <input class="form-check-input" type="radio" name="gender" value="남" checked>남
            </label>
        </div>
        <div class="form-group form-check">
            <label class="form-check-label">
                <input class="form-check-input" type="radio" name="gender" value="여">여
            </label>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form>
</div>
</body>
</html>
