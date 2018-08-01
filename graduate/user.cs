using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using graduate.Resources;

namespace graduate
{
    /*------------유저 오브젝트------------*/
    // DB 연동하기 이전 임시 객체
    // 유저 정보, 파일 리스트
    // 가상파일시스템의 파일&디렉토리 생성 및 삭제
  
    public class USER
    {
        string ID;
        string Password;
        string Name = "";
        public string getName() { return this.Name; }
        public string getId() { return this.ID; }
        public string getPassword() { return this.Password; }
        public USER(string str1, string str2)
        {
            ID = str1;
            Password = str2;
        }
        public USER(string str1, string str2, string str3)
        {
            ID = str1;
            Password = str2;
            Name = str3;
        }

        // 클라우드 저장 정보
        fileSystem userFileSystem = new fileSystem();
        public void fileAdd(userFile file1)
        {
            userFileSystem.fileList.Add(file1);    // USER의 fileList에 파일리스트 정보 저장
        }

        public class fileSystem
        {
            String currentPath;
            public List<userFile> fileList = new List<userFile>();
        }
    }
}
