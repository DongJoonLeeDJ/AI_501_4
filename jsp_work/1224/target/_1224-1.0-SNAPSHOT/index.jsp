<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
    <%@ include file="head.jsp"%>
    <script>
        $('document').ready(function(){
           $('#logout').on('click',function(){
               window.location='logout.jsp';
           });
        });
    </script>
</head>
<body>
<%@ include file="nav.jsp"%>
<div class="container">
    <div class="row p-3">
        <%
            String email = "";
            String pwd = "";
            Cookie cos[] = request.getCookies();

            if (cos!=null) {
                for (Cookie co : cos) {
                    if (co.getName().equals("email"))
                        email = co.getValue();
                    if (co.getName().equals("pwd"))
                        pwd = co.getValue();
                }
            }

            Object emailobj = session.getAttribute("email");
            if (emailobj == null){
        %>
        <div class="col-md-4 pt-5">
            <h1>로그인창</h1>
            <form action="/1224_war_exploded/loginproc.jsp">
                <div class="form-group">
                    <label for="email">Email address:</label>
                    <input type="email" class="form-control" id="email" name="email" value="<%=email%>">
                </div>
                <div class="form-group">
                    <label for="pwd">Password:</label>
                    <input type="password" class="form-control" id="pwd" name="pwd" value="<%=pwd%>">
                </div>
                <div class="checkbox">
                    <!-- cookie 설정 하면 자동으로 아이디 패스워드값 설정 되어 있는거... -->
                    <label><input type="checkbox" name="loginsave" value="true"> Remember me</label>
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
        </div>
        <%
            }else{
        %>
        <div class="col-md-4 pt-5">
            로그인했음.<br>
            <img src="img/saram.jpg" width="100%"><br>
            <%=emailobj %> 님 환영 합니다.
            <button class="btn btn-primary" id="logout">로그아웃</button>
        </div>
        <% } %>
        <div class="col-md-8">
            <h1>광고창</h1>
            <iframe width="100%" height="360"
                    src="https://www.youtube.com/embed/aVsdnqEADK8"
                    title="YouTube video player" frameborder="0"
                    allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                    allowfullscreen></iframe>
        </div>
    </div>
    <div class="row p-3">
        <div class="col-md-12">
            <div class="jumbotron">
                <h1>안녕하세요</h1>
                <p>대통령은 국무총리·국무위원·행정각부의 장 기타 법률이 정하는 공사의 직을 겸할 수 없다. 헌법개정은 국회재적의원 과반수 또는 대통령의 발의로 제안된다.
                    헌법개정안이 제2항의 찬성을 얻은 때에는 헌법개정은 확정되며, 대통령은 즉시 이를 공포하여야 한다. 모든 국민은 그 보호하는 자녀에게 적어도 초등교육과 법률이 정하는 교육을 받게 할 의무를 진다.</p>
            </div>
            <p>헌법재판소 재판관은 정당에 가입하거나 정치에 관여할 수 없다. 대한민국의 경제질서는 개인과 기업의 경제상의 자유와 창의를 존중함을 기본으로 한다.</p>
            <p>모든 국민은 언론·출판의 자유와 집회·결사의 자유를 가진다. 대한민국은 국제평화의 유지에 노력하고 침략적 전쟁을 부인한다. 탄핵소추의 의결을 받은 자는 탄핵심판이 있을 때까지 그 권한행사가 정지된다.</p>
        </div>
    </div>
    <div class="row">
        <a href="/1224_war_exploded/fileupload/aa1.jpg">aa1.jpg</a>
    </div>
</div>
</body>
</html>