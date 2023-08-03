using UnityEngine;
//キャラクターの移動スクリプト
[RequireComponent(typeof(CharacterController))] //キャラクターコントローラーをアタッチ
public class ChikinController : MonoBehaviour
{
    [SerializeField] Animator animator; //アニメーション(インスペクタ)
    public static float moveSpeed = 5.0f; //移動速度(インスペクタ)
    private CharacterController _characterController; 
    private Transform _transform;
    public Vector3 _moves; //移動の設定(値を入れると移動する。yは重力)

    private void Start()
    {
        //キャッシュ
        _characterController = GetComponent<CharacterController>();
        _transform = transform;

        //フレームレートを固定化
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        //xの移動(横)
        _moves.x = Input.GetAxis("Horizontal") * moveSpeed;
        //zの移動(前に移動し続ける)
        _moves.z = moveSpeed;

        //プレイヤーの向き
        _transform.LookAt(_transform.position + new Vector3(_moves.x, 0, _moves.z));
        //移動の設定
        _characterController.Move(_moves * Time.deltaTime);
        //アニメーションの設定
        animator.SetFloat("MoveSpeed", new Vector3(_moves.x, 0, _moves.z).magnitude);
    }
}
