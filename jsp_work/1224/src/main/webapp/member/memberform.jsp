<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
%>
<html>
<head>
    <title>Title</title>
    <%@ include file="../head.jsp"%>
    <script>
        var result = "false";
        function doChk(){
            var aobj= {
                url: "memberchk.jsp",
                type: "get",
                cache: true,
                dataType: "text",
                data: {id: $('#email').val(), b:20},
                success: function(data,result){
                    result = data.trim();
                    $('#result').html(result);
                },
                error: function (request, status){
                    alert(status);
                }
            };
            $.ajax(aobj);
        }
        function doSubmit(){
            result = $('#result').html();
            if(result =="true") {
                alert("일로온다.");
                return true;
            }
            else{
                alert("아이디 중복 체크 하셔야 됩니다.");
                return false;
            }
        }
    </script>
</head>
<body>
<%@ include file="../nav.jsp" %>
<div class="container">
    <form action="memberproc.jsp" onsubmit="return doSubmit()">
        <div class="form-group mt-3">
            <label for="email">email </label>
            <input type="email"
                   class="form-control"
                   style="width: 20%; display: inline;"
                   placeholder="Enter email"
                   id="email"
                   name="email"
                   value="aa@naver.com">
            <button class="btn btn-primary" type="button" onclick="doChk();">중복체크</button>
            <span id="result"></span>
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
