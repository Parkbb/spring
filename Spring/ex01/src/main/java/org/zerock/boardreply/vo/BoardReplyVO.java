package org.zerock.boardreply.vo;

import java.util.Date;

import lombok.Data;

@Data
public class BoardReplyVO {
	
	private long rno, no;
	private String reply, replyer;
	private Date replyDate, updateDate;
	
}
