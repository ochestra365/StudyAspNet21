namespace DotNetNote.Models
{
    public enum BoardWriteFormType//enum은 열거형이고 관련있는 값들을 적어두는 것이다.
    {
        Write,          //글쓰기 모드
        Modify,         //글 수정 모드
        Reply           //댓글모드
    }

    public enum ContentEncodingType
    {
        Text,       //일반텍스트
        Html,       //HTML입력모드
        Mixed       //HTML입력+엔터키
    }

}