package org.zerock.board.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import lombok.Data;
import lombok.Setter;


//Spring 자동생성 어노테이션 -@Controller, @Component, @Service, @Repository, @RestController, @Advice
//root-contest.xml에 설정이 되어 있어야 한다. <annotation-driven /> <context:component-scan base-package="org.zerock" />
@Service
@Data
public class BoardServiceImpl {
	
	@Setter(onMethod_ = @Autowired)
	private BoardServiceImpl dao;
	
}
