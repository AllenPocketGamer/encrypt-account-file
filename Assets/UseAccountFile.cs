using UnityEngine;
using IC;
using Newtonsoft.Json;

public class UseAccountFile : MonoBehaviour
{
    void Start()
    {
        // 创建KeyStore, 一种加密账户
        var acName = "My Account Name";
        var acPwd = "123456";
        var keystore = Agent.CreateKeyStore(acName, acPwd);
        
        // HostKeyStore支持序列化/反序列化(Json)
        var keystoreJson = JsonConvert.SerializeObject(keystore);
        Debug.Log(keystoreJson);
        
        // TODO: 因为keystoreJson是文本形式的, 可以简单存储到文本文件中;
        
        // 同样, HostKeyStore可以反序列化(Json)
        var keystoreAgain = JsonConvert.DeserializeObject<HostKeyStore>(keystoreJson);
        Debug.Log(keystoreAgain);
        
        // TODO: HostKeyStore之后会支持修改密码(之前支持, 但发现有安全问题, 暂时屏蔽了)
    }

}
