/**
 * 댓글 객체 선언해서 사용.
 */
 
 console.log("asdfReply Module ...");
 
 var replyService = (function(){
 	
 	// list(전달 데이터, 성공하면 실행할 함수, 실패하면 실행할 함수)
 	// param = {no:10, page:1}
 	function list(param, callback, error){
 		var no = param.no;
 		var page = param.page;
 		
 		// ajax 함수 한 줄
 		$.getJSON(
 			"/boardreply/list.do?page=" + page + "&no=" + no,
 			function(data){
 				// 성공하면 실행할 함수가 있다면 실행
 				if(callback){
 					console.log("data = " + JSON.stringify(data));
 					callback(data);
 				} else {
 					alert(data);
 				}
 			}
 		).fail(function(xhr, status, err){ // 실패했을 때의 처리 시작 - function(통신객체, 상태, 에러)
 			if(error){
 				error();
 			} else {
 				console.log("xhr=" + xhr);
 				console.log("status=" + status);
 				console.log("err=" + err);
 				alert("댓글 리스트 가져오다가 문제가 생겼습니다.");
 			}
 		})
 		;
 	}
 	
 	return {
 		// 함수 리턴
 		list:list //replyservice.list()
 	}
 
 })(); //JSON 객체 선언 방법