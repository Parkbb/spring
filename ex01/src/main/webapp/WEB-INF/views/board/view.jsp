<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<!-- <meta name="viewport" content="width=device-width, initial-scale=1"> -->
<!-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"> -->
<!-- <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script> -->
<!-- <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script> -->
<style type="text/css">
	#deleteDiv{
		display: none;
	}
</style>
<script type="text/javascript">
	$(function(){
		$('#deleteBtn').click(function(){
			$('#deleteDiv').slideDown();
		});
	});

	$(function(){
		$('#deleteCancel').click(function(){
			$('#deleteDiv').slideUp();
		});
	});
	
</script>

</head>
<body>
	
	
	<div class="card-header py-3">
		게시판 글보기
 	</div>
 	<div class="card-body">
	<table class="table">
		<tbody>
			<tr>
				<th>글번호</th>
				<td>${vo.no }</td>
			</tr>
			<tr>
				<th>제목</th>
				<td>${vo.title }</td>
			</tr>
			<tr>
				<th>내용</th>
				<td>${vo.content }</td>
			</tr>
			<tr>
				<th>작성자</th>
				<td>${vo.writer }</td>
			</tr>
			<tr>
				<th>작성일</th>
				<td><fmt:formatDate value="${vo.writeDate }" pattern="yyyy-MM-dd"/></td>
			</tr>
			<tr>
				<th>조회수</th>
				<td><fmt:formatNumber pattern="#,###" value="${vo.hit }" /></td>
			</tr>
		</tbody>
	</table>
	<a href="update.do?no=${vo.no}" class="btn btn-default">수정</a>
	<a href="#" class="btn btn-default" onclick="retrun false" id="deleteBtn">삭제</a>
	<a href="list.do" class="btn btn-default">목록</a>
	<div id="deleteDiv">
		<form action="delete.do" method="post">
			<input name="no" value="${vo.no }" type="hidden">
			<div class="form-group">
				<label>본인 확인용 비밀번호 입력 :</label>
				<input name="pw" class="form-control" type="password">
			</div>
			<button class="btn btn-danger btn-sm">삭제</button>
			<button class="btn btn-info btn-sm" type="button" id="deleteCancel">취소</button>
		</form>
	</div>
</div>
</body>
</html>