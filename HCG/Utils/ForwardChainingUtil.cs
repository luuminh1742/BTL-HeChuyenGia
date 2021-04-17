using HCG.BLL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.Utils
{
    class ForwardChainingUtil
    {
        /**
         * Phuong thuc tra ve ket qua cua suy dien tien voi dau vao
         * la danh sach gia thiet (assumptions)
         */
        public static List<MobileDTO> Result(List<string> assumptions)
        {
            // Ket qu
            var result = new List<MobileDTO>();
            // Lay tat ca cac luat trong database
            List<RuleDTO> rules = RulesBLL.FindAll();
            List<RuleDTO> rulesCopy = RulesBLL.FindAll();
            // Lay tat ca cac doi tuong mobile trong database
            var mobiles = MobileBLL.FindAll();
            //var mobileId = mobile.Id;
            // Gan trung gian bang gia thiet
            List<string> mediate = assumptions;
            // Loc SAT
            Queue<int> SAT = new Queue<int>();
            SAT = FilterSAT(rulesCopy, mediate);
            while (SAT.Count != 0)
            {
                var ruleId = SAT.Dequeue();// Lay ra ruleId va xoa khoi hang doi
                RuleDTO rule = rules.Find(item => item.Id == ruleId);
                if (rule == null) continue;
                mediate.AddRange(rule.Right);
                SAT = FilterSAT(rulesCopy, mediate);
                if (rulesCopy.Count == 0) break;
            }
            mobiles.ForEach(mobile =>
            {
                if (mediate.Contains(mobile.Id))
                {
                    result.Add(mobile);
                }
            });
            return result;
        }


        private static Queue<int> FilterSAT(List<RuleDTO> rules, List<string> mediate)
        {
            var result = new Queue<int>();
            for(int i = rules.Count - 1; i >= 0; i--)
            {
                var rule = rules[i];
                bool isContainAll = true;
                
                foreach (string left in rule.Left)
                {
                    if (!mediate.Contains(left))
                    {
                        isContainAll = false;
                        break;
                    }
                }
                if (isContainAll)
                {
                    result.Enqueue(rule.Id);
                    rules.Remove(rule);
                }
            }
            return result;
        }
        private static List<int> dFilterSAT(List<RuleDTO> rules,List<string> mediate)
        {
            var result = new List<int>();
            rules.ForEach(rule =>
            {
                
                bool isContainAll = true;
                foreach(string left in rule.Left)
                {
                    if (!mediate.Contains(left))
                    {
                        isContainAll = false;
                    }
                }
                if (isContainAll)
                {
                    result.Add(rule.Id);
                }
            });
            return result;
        }
    }
}
