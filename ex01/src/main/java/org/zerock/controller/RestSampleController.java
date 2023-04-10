package org.zerock.controller;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.zerock.board.vo.BoardVO;

import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@RestController
@RequestMapping("/rest")
@Log4j
public class RestSampleController {
	
	@GetMapping(value =  "/getText", produces = "text/plain; charset=UTF-8")
	public String getText() {
		return "안녕안녕";
	}
	
	
	
	
	// xml --> <no>10</no><title>게시판입니다.</title>
	// JSON --> { no:10, title:"게시판 입니다."}
	// produces = {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE}) -> JSON 데이터와 XML 데이터 모두 저장
	@GetMapping(value = "/getMap", 
			produces = {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE})
	public Map<String, Object> getMap() {
		List<BoardVO> list  = new ArrayList<BoardVO>();
		BoardVO vo = new BoardVO();
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		list.add(vo);
		
		BoardVO vo2 = new BoardVO();
		vo.setNo(11);
		vo.setTitle("게시판2입니다.");
		list.add(vo2);
		
		PageObject pageObject = new PageObject();
		
		// list와 pageObject를 동시에 넘겨야 한다.
		Map<String, Object> map = new HashMap<String, Object>();
		map.put("list", list);
		map.put("pageObject", pageObject);
		
		return map;
	}
	
	//Ajax를 사용하다보면 내부에 오류가 정상적인 처리가 됐는지? -> 처리 상태를 알려주는 객체 - ResponseEntity 객체 사용
	//@GetMapping(value = "/check")
	@GetMapping(value = "/check", params = {"height", "weight"})
	public ResponseEntity<BoardVO> check(Double height, Double weight){
		ResponseEntity<BoardVO> result = null;
		BoardVO vo = new BoardVO();
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		
		if(height < 150) {
			result = ResponseEntity.status(HttpStatus.BAD_GATEWAY).body(vo);
		} else {
			result = new ResponseEntity<BoardVO>(vo, HttpStatus.OK);
		}
		
		
		return result;
	}
	
}
