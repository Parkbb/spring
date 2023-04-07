package org.zerock.board.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;
import org.zerock.board.mapper.BoardMapper;
import org.zerock.board.vo.BoardVO;

import com.webjjang.util.PageObject;

import lombok.Setter;

@Service
@Qualifier("boardServiceImpl")
public class BoardServiceImpl implements BoardService{
	
	@Setter(onMethod_ = @Autowired) // 자동 DI
	private BoardMapper mapper;
	
	@Override
	public List<BoardVO> list(PageObject pageObject) {
		// setTotlaRow() 안에 startRow, endRow를 계산하는 처리가 있다. 안하면 데이터를 가져오지 못함
		pageObject.setTotalRow(mapper.getTotalRow(pageObject));
		return mapper.list(pageObject);
	}

	@Override
	public BoardVO view(long no,int inc) {
		// TODO Auto-generated method stub
		if(inc ==1) mapper.increase(no);
		return mapper.view(no);
	}

	@Override
	public int write(BoardVO vo) {
		// TODO Auto-generated method stub
		return mapper.write(vo);
	}

	@Override
	public int update(BoardVO vo) {
		// TODO Auto-generated method stub
		return mapper.update(vo);
	}

	@Override
	public int delete(BoardVO vo) {
		// TODO Auto-generated method stub
		return mapper.delete(vo);
	}

}
