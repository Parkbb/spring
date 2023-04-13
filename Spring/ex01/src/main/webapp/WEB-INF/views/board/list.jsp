<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@ taglib prefix="pageNav" tagdir="/WEB-INF/tags" %>
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
	.dataRow:hover{
		background: #eee;
		cursor: pointer;
	}
</style>
<script type="text/javascript">
	$(function(){
		//alert("jQuery loading");
		$(".dataRow").click(function(){
			var no = $(this).find(".no").text();
			//alert("글번호: " + no);
			location = "view.do?no=" + no + "&inc=1";
		});
	});
</script>
</head>
<body>
	<div class="card-header py-3">
		게시판 리스트
	</div>
	<div class="card-body">
	<table class="table">
		<thead>
			<tr>
				<th>글번호</th>
				<th>제목</th>
				<th>작성자</th>
				<th>작성일</th>
				<th>조회수</th>
			</tr>
		</thead>
		<tbody>
			<c:forEach items="${list}" var="vo">
					<tr class="dataRow">
						<td class="no">${vo.no }</td>
						<td>${vo.title }</td>
						<td>${vo.writer }</td>
						<td><fmt:formatDate value="${vo.writeDate }" pattern="yyyy-MM-dd"/> </td>
						<td><fmt:formatNumber value="${vo.hit }" pattern="#,###" /> </td>
					</tr>
				</c:forEach>
		</tbody>
	</table>
	<a href="write.do" class="btn btn-default">글쓰기</a>
	<div><pageNav:pageNav listURI="list.do" pageObject="${pageObject }" /></div>
	</div>
<%-- <c:if test="${msg != null }"> --%>
<%-- 	<%@ include file="../common/message.jspf" %> --%>
<%-- </c:if>	 --%>
	
</body>
</html>