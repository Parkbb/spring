<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>게시판 글보기</h1>
	<a href="update.do">수정</a>
	<a href="list.do">목록</a>
	<div>
		<form action="delete.do" method="post">
			<input name="no" value="10">
			<input name="no" value="11">
			<input name="no" value="15">
			<button>삭제</button>
		</form>
	</div>
</body>
</html>