package org.zerock.boardreply.controller;

import java.util.HashMap;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.zerock.boardreply.service.BoardReplyService;

import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@RestController
@RequestMapping("/boardreply")
@Log4j
public class BoardReplyController {
	
	
	@Autowired
	@Qualifier("boardReplyServiceImpl")
	private BoardReplyService service;
	
	
	@GetMapping(value = "/list.do", produces = {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE})
	public ResponseEntity<Map<String, Object>> list(PageObject pageObject, long no){
		log.info("댓글 리스트");
		log.info("pageObject = " + pageObject + ", no = " + no);
		Map<String, Object> map = new HashMap<String, Object>();
		
		map.put("list",service.list(pageObject, no));
		map.put("pageObjecct", pageObject);
		
		log.info("map = : " + map);
		return new  ResponseEntity<Map<String, Object>> (map, HttpStatus.OK);
	}
	
}
