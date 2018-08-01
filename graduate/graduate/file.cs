using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduate.Resources
{
    public class userFile  // 각 유저정보DB에 저장할 file 객체
    {
        private String fileName;    // 파일 이름
        private String fileType;    // 파일 타입(확장자)
        private String fromCloud;   // 파일이 저장된 클라우드 종류(google, one, ...)
        private String fileAddress; // 파일이 통합클라우드 내에 저장되어있는 논리적 주소
                                    // ex) root-dir1-dir2-file
                                    // private int fileSecurity;   // 파일 보안 정도                                    
                                    // private int fileSize;    // 파일 크기 >> 클라우드 분류 기준

        public userFile(String fileName,String fileType,String fromCloud,String fileAddress)
        {
            this.fileName = fileName;
            this.fileType = fileType;
            this.fromCloud = fromCloud;
            this.fileAddress = fileAddress;
        }

        public void setFileName(String str)
        {
            this.fileName = str;
        }
        public String getFileName()
        {
            return this.fileName;
        }

        public void setFileType(String str)
        {
            this.fileType = str;
        }
        public String getFileType()
        {
            return this.fileType;
        }

        public void setFromCloud(String str)
        {
            this.fromCloud = str;
        }
        public String getFromCloud()
        {
            return this.fromCloud;
        }

        public void setFileAddress(String str)
        {
            this.fileAddress = str;
        }
        public String getFileAddress()
        {
            return this.fileAddress;
        }
    }
}
