﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Car
    {
        /***
         *  carNumber : 자동차 번호
         ***/


        /// <summary>
        /// 자동차가 들어온 시간 설정
        /// </summary>
        /// 
        int carNumber;
        DateTime inTime;
        DateTime outTime;
         
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나간 시간 설정
        /// </summary>
       
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}