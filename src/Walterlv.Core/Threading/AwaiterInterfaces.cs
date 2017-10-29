using System.Runtime.CompilerServices;

namespace Walterlv.Threading
{
    /// <summary>
    /// ��ʾһ���ɵȴ��������һ���������ش����͵�ʵ������˷�������ʹ�� `await` �첽�ȴ���
    /// </summary>
    /// <typeparam name="TAwaiter">���ڸ� await ȷ������ʱ���� IAwaiter ��ʵ����</typeparam>
    public interface IAwaitable<out TAwaiter> where TAwaiter : IAwaiter
    {
        TAwaiter GetAwaiter();
    }

    /// <summary>
    /// ��ʾһ����������ֵ�Ŀɵȴ��������һ���������ش����͵�ʵ������˷�������ʹ�� `await` �첽�ȴ�����ֵ��
    /// </summary>
    /// <typeparam name="TAwaiter">���ڸ� await ȷ������ʱ���� IAwaiter{<typeparamref name="TResult"/>} ��ʵ����</typeparam>
    /// <typeparam name="TResult">�첽���صķ���ֵ���͡�</typeparam>
    public interface IAwaitable<out TAwaiter, out TResult> where TAwaiter : IAwaiter<TResult>
    {
        TAwaiter GetAwaiter();
    }

    /// <summary>
    /// ���ڸ� await ȷ���첽���ص�ʱ����
    /// </summary>
    public interface IAwaiter : INotifyCompletion
    {
        bool IsCompleted { get; }

        void GetResult();
    }

    /// <summary>
    /// ��ִ�йؼ����루�˴����еĴ�����ܸ�Ӧ�ó����е�����״̬��ɸ���Ӱ�죩ʱ��
    /// ���ڸ� await ȷ���첽���ص�ʱ����
    /// </summary>
    public interface ICriticalAwaiter : IAwaiter, ICriticalNotifyCompletion
    {
    }

    /// <summary>
    /// ���ڸ� await ȷ���첽���ص�ʱ��������ȡ������ֵ��
    /// </summary>
    /// <typeparam name="TResult">�첽���صķ���ֵ���͡�</typeparam>
    public interface IAwaiter<out TResult> : INotifyCompletion
    {
        bool IsCompleted { get; }

        TResult GetResult();
    }

    /// <summary>
    /// ��ִ�йؼ����루�˴����еĴ�����ܸ�Ӧ�ó����е�����״̬��ɸ���Ӱ�죩ʱ��
    /// ���ڸ� await ȷ���첽���ص�ʱ��������ȡ������ֵ��
    /// </summary>
    /// <typeparam name="TResult">�첽���صķ���ֵ���͡�</typeparam>
    public interface ICriticalAwaiter<out TResult> : IAwaiter<TResult>, ICriticalNotifyCompletion
    {
    }
}
