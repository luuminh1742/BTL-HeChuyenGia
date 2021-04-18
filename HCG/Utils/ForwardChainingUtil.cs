using HCG.BLL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.Utils
{
    class ForwardChainingUtil
    {
        /// <summary>
        /// Phuong thuc tra ve ket qua cua suy dien tien voi dau vao
        /// la danh sach gia thiet (assumptions)
        /// </summary>
        /// <param name="assumptions"></param>
        /// <returns></returns>
        public static List<MobileDTO> Result(List<string> assumptions)
        {
            // Ket qu
            var result = new List<MobileDTO>();
            // Lay tat ca cac luat trong database
            List<RuleDTO> rules = OptimizeRule(RulesBLL.FindAll());
            List<RuleDTO> rulesCopy = new List<RuleDTO>(rules);

            // Lay tat ca cac doi tuong mobile trong database
            var mobiles = MobileBLL.FindAll();
            //var mobileId = mobile.Id;
            // Gan trung gian bang gia thiet
            List<string> mediate = assumptions;
            // Loc SAT
            Queue<int> SAT = new Queue<int>();
            SAT = FilterSAT(rulesCopy, mediate);
            // Duyet SAT cho den khi tap SAT rong
            while (SAT.Count != 0)
            {
                // Xet rule dau tien trong tap SAT
                // Lay ra ruleId va xoa khoi hang doi
                var ruleId = SAT.Dequeue();
                // Tim rule theo ruleid
                RuleDTO rule = rules.Find(item => item.Id == ruleId);
                // Neu khong tim duoc rule thì bo qu vong lap nay
                if (rule == null) continue; 
                // Them su kien vao bien trung gian
                mediate.Add(rule.Right);
                // Tim SAT
                SAT = FilterSAT(rulesCopy, mediate);

                if (rulesCopy.Count == 0) break;
            }
            // Neu Bien trung gian co chua mobile thi them vao ket qu
            mobiles.ForEach(mobile =>
            {
                if (mediate.Contains(mobile.Id))
                {
                    result.Add(mobile);
                }
            });
            return result;
        }

        /// <summary>
        /// Phuong thuc tim tap SAT trong tap luat
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="mediate"></param>
        /// <returns></returns>
        private static Queue<int> FilterSAT(List<RuleDTO> rules, List<string> mediate)
        {
            var result = new Queue<int>();
            // Tim cac luat tu cuoi 
            for(int i = rules.Count - 1; i >= 0; i--)
            {
                // Xet luat thu i
                var rule = rules[i];
                // Bien kiem tra xem cac su kien trong luat thu i co nam trong bien trung gian hay khong
                bool isContainAll = true;
                
                foreach (string left in rule.Left)
                {
                    if (!mediate.Contains(left))
                    {
                        isContainAll = false;
                        break;
                    }
                }
                // Neu tat ca su kien cua luat deu nam trong bien trung gian thi them luat day vao SAT
                // Dong thoi xoa luat day khoi tap luat
                if (isContainAll)
                {
                    result.Enqueue(rule.Id);
                    rules.Remove(rule);
                }
            }
            return result;
        }


        /// <summary>
        /// Phuong thuc toi uu hoa tap luat
        /// </summary>
        /// <param name="rules"></param>
        /// <returns></returns>
        private static List<RuleDTO> OptimizeRule(List<RuleDTO> rules)
        {
            // Loai bo luat du thua
            RemoveRuleRedundant(rules);
            //Loai bo su kien du thua
            //RemoveEventRedundant(rules);
            return rules;
        }

        private static void RemoveEventRedundant(List<RuleDTO> rules)
        {
            throw new System.NotImplementedException();
        }

        public static List<RuleDTO> testRule()
        {
            List<RuleDTO> rules = RulesBLL.FindAll();
            RemoveRuleRedundant(rules);
            return rules;
        }
        private static void RemoveRuleRedundant(List<RuleDTO> rules)
        {
            int i = 0;
            var checkRule = new RuleDTO();
            var SAT = new Queue<int>();
            var rulesCopy = new List<RuleDTO>();
            var mediate = new List<string>();
            while (i < rules.Count)
            {
                checkRule = rules[i];
                rulesCopy.AddRange(rules);
                rulesCopy.Remove(checkRule);
                mediate.AddRange(checkRule.Left);
                
                foreach (RuleDTO rule in rules)
                {
                    if (rule.Equals(checkRule)) continue;
                    // Loc SAT
                    SAT = FilterSAT(rulesCopy, mediate);
                    // Duyet SAT cho den khi tap SAT rong
                    while (SAT.Count != 0)
                    {
                        // Xet rule dau tien trong tap SAT
                        // Lay ra ruleId va xoa khoi hang doi
                        var ruleId = SAT.Dequeue();
                        // Tim rule theo ruleid
                        RuleDTO r = rules.Find(item => item.Id == ruleId);
                        // Neu khong tim duoc rule thì bo qu vong lap nay
                        if (r == null) continue;
                        // Them su kien vao bien trung gian
                        mediate.Add(r.Right);
                        // Tim SAT
                        SAT = FilterSAT(rulesCopy, mediate);
                        if (rulesCopy.Count == 0) break;
                    }
                }
                if (mediate.Contains(checkRule.Right.Trim()))
                {
                    rules.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                SAT.Clear();
                mediate.Clear();
                rulesCopy.Clear();
            }
        }
    }
}
