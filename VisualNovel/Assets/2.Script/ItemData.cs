using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [System.Serializable]
    public class ItemData
    {
        public string id; // 고유 ID
        public string name; // 아이템 이름
        public string description; // 아이템 설명
        public string iconPath; // 아이콘 경로
        public int baseValue; // 기본 가치
        public string category; // 카테고리 (예: 소비 아이템, 무기 등)
    }


