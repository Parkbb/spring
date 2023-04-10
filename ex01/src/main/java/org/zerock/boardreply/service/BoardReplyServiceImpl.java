package org.zerock.boardreply.service;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;
import org.zerock.boardreply.mapper.BoardReplyMapper;
import org.zerock.boardreply.vo.BoardReplyVO;

import com.webjjang.util.PageObject;

import lombok.Setter;


@Service
@Qualifier("boardReplyServiceImpl")
public class BoardReplyServiceImpl implements BoardReplyService {
	
	@Setter(onMethod_ = @Autowired)
	private BoardReplyMapper mapper;
	
	
	@Override
	public List<BoardReplyVO> list(PageObject pageObject, long no) {
		// TODO Auto-generated method stub
		Map<String, Object> map = new HashMap<String, Object>();
		map.put("no", no);
		map.put("pageObject", pageObject);
		pageObject.setTotalRow(mapper.getTotalRow(map));
		return mapper.list(map);
	}


	@Override
	public int write(BoardReplyVO vo) {
		// TODO Auto-generated method stub
		return mapper.write(vo);
	}

	@Override
	public int update(BoardReplyVO vo) {
		// TODO Auto-generated method stub
		return mapper.update(vo);
	}

	@Override
	public int delete(long rno) {
		// TODO Auto-generated method stub
		return mapper.delete(rno);
	}

}
