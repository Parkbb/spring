package org.zerock.boardreply.service;

import java.util.List;
import java.util.Map;

import org.zerock.boardreply.vo.BoardReplyVO;

import com.webjjang.util.PageObject;

public interface BoardReplyService {
	
	public List<BoardReplyVO> list(PageObject pageObject, long no);
	
	public int write(BoardReplyVO vo);
	
	public int update(BoardReplyVO vo);
	
	public int delete(long rno);
	
}
