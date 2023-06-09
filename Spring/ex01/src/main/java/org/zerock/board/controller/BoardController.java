package org.zerock.board.controller;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;
import org.zerock.board.service.BoardService;
import org.zerock.board.vo.BoardVO;

import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@Controller
@RequestMapping("/board")
@Log4j
public class BoardController {
	
	@Autowired
	@Qualifier("boardServiceImpl")
	private BoardService service;
	
	
	@RequestMapping("/list2.do")
	public String list() {
		log.info("게시판 리스트2......................");
		//System.out.println(10/0);
		return "board/list2";
	}
	
	@RequestMapping("/list.do")
	public String list(@ModelAttribute("pageObject") PageObject pageObject, Model model) {
		log.info("게시판 리스트......................");
		//System.out.println(10/0);
		model.addAttribute("list", service.list(pageObject));
		return "board/list";
	}
	
	@RequestMapping("/view.do")
	public String view(long no, int inc, Model model) {
		log.info("게시판 글보기......................");
		log.info(no + ":" + inc);
		model.addAttribute("vo", service.view(no, inc));
		return "board/view";
	}
	
	@GetMapping("/write.do")
	public String writeForm() {
		log.info("게시판 글쓰기 폼......................");
		return "board/write";
	}
	
	@PostMapping("/write.do")
	public String write(BoardVO vo, long perPageNum, RedirectAttributes rttr) {
		log.info("게시판 글쓰기 처리......................");
		service.write(vo);
		rttr.addFlashAttribute("msg", "글 등록 됨");
		return "redirect:list.do?perPageNum=" + perPageNum;
	}
	
	@GetMapping("/update.do")
	public String updateForm(long no, Model model) {
		log.info("게시판 수정 폼......................");
		model.addAttribute("vo", service.view(no, 0));
		return "board/update";
	}
	
	@PostMapping("/update.do")
	public String update(BoardVO vo) {
		log.info("게시판 수정 처리......................");
		service.update(vo);
		return "redirect:view.do?no="+vo.getNo()+"&inc=0";
	}
	
	@PostMapping("/delete.do")
	// @RequestParam([name, dafaultValue, required, value]) - 넘어오는 데이터의 이름이 변수와 다른 경우, 값이 넘어오지 않는 경우 기본 값,
	// 필수 항목, 값 세팅
//	public String delete(@RequestParam("no") ArrayList<Long> no) {
//		public String delete(long[] no) {
		public String delete(BoardVO vo) {
		log.info("게시판 삭제......................");
//		log.info(Arrays.toString(no));
//		log.info(no);
		log.info(vo); // no, pw
		service.delete(vo);
		return "redirect:list.do";
	}
	

	
}
