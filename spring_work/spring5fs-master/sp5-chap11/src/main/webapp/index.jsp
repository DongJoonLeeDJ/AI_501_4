<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<a href="<c:url value="/main" />">main</a>
<p>
1. mybatis 설정 
(1)pom.xml jar 파일 가져오기
(2) datasource 객체 
(3) sqlsessiontemplate mybatis사용객체 선언
(4) mapper.xml
2. webapp 밑에 web-inf 폴더는 보안상 접근불가
3. command object 
<form:form> taglib 사용하는거
5. redirect:/main
response.sendredirect();
6. mapper.xml
parameterType 넘겨주는거
resultType 반환받는걸로 사용한다.
</p>
</body>
</html>