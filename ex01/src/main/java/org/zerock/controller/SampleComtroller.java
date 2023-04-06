package org.zerock.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import lombok.extern.log4j.Log4j;

// uri - /sample/*
// mapping은 클래스 위에, 메서드 위에 -> 클래스 매핑 + 메서드 매핑 ==> 전체 uri에 해당이 된다.
@Controller
@RequestMapping("/sample/*")
@Log4j
public class SampleComtroller {
	
	// String - redirect: 에 안붙으면 jsp로 forward, redirect:이 붙어 있으면 페이지 이동
	// void면 uri가 jsp의 정보가 된다. 예) /sample/test -> /sample/test.jsp를 자동 찾는다.
	@RequestMapping("/basic")

	public void basic() {
		log.info("basic......................");
	}
	@RequestMapping(value="/basicGet" , method = RequestMethod.GET)
	public void basicGet() {
		log.info("basicGet()......................");
	}
	
	// @RequestMapping에서 Get 방식만 받도록 정의해 놓은 어노테이션 -> @GetMapping
	@GetMapping("/basicGet2")
	public void basicGet2() {
		log.info("basicGet2()......................");
	}
}
