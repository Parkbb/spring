package org.zerock.image.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.multipart.MultipartFile;
import org.zerock.controller.SampleComtroller;

import lombok.extern.log4j.Log4j;

//uri - /sample/*
//mapping은 클래스 위에, 메서드 위에 -> 클래스 매핑 + 메서드 매핑 ==> 전체 uri에 해당이 된다.
@Controller
@RequestMapping("/image")
@Log4j
public class ImageController {
	
	String module = "image";
	
	// 이미지를 선택해서 보내주는 처리
	@GetMapping("/write.do")
	public String writeForm() {
		return module + "/write";
	}
	
	// 이미지를 받아서 보내주는 처리
	@PostMapping("/write.do")
	public String write(String title, MultipartFile[] files) {
		
		log.info(title);
		for (MultipartFile multipartFile : files) {
			if(!multipartFile.getOriginalFilename().equals("") && multipartFile.getOriginalFilename() != null) {
				log.info("---------------------------------");
				log.info(multipartFile.getOriginalFilename());
				log.info(multipartFile.getSize());
			}
		}
		
		return "redirect:list.do";
	}
	
}
